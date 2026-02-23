using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Calocitta;

/// <summary>
/// Abstract class for Calocitta (genus).
/// NCBI TaxId: 54580
/// </summary>
public abstract class Calocitta : Corvidae, ICalocitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calocitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54580;

    /// <inheritdoc />
    public virtual string GenusName => "Calocitta";

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
