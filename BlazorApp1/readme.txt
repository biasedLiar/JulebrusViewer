SELECT ROUND(AVG(gjett_count), 2) AS riktige_gjett, MAX(gjett_count) as max_riktige, riktig_gjett.person_id AS Id FROM (SELECT COUNT(*) AS gjett_count, gjett.person_id as person_id, gjett.event_id as event_id FROM gjett WHERE gjett.brus_id = gjett.gjett GROUP BY gjett.person_id, gjett.event_id) as riktig_gjett GROUP BY person_id

<h2 class="NumbStat_number">@numbStatModel.Number</h2>

        <p class="NumbStat_text">@numbStatModel.Category</p>
        <p class="NumbStat_text">@numbStatModel.Details</p>

        