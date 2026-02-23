using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Dicrolene;

/// <summary>
/// Abstract class for Dicrolene (genus).
/// NCBI TaxId: 1003168
/// </summary>
public abstract class Dicrolene : Ophidiidae, IDicrolene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicrolene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003168;

    /// <inheritdoc />
    public virtual string GenusName => "Dicrolene";

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
