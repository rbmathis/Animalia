using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Drymocichla;

/// <summary>
/// Abstract class for Drymocichla (genus).
/// NCBI TaxId: 1306880
/// </summary>
public abstract class Drymocichla : Cisticolidae, IDrymocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306880;

    /// <inheritdoc />
    public virtual string GenusName => "Drymocichla";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
