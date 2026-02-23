using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Sitta;

/// <summary>
/// Abstract class for Sitta (genus).
/// NCBI TaxId: 50248
/// </summary>
public abstract class Sitta : Sittidae, ISitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50248;

    /// <inheritdoc />
    public virtual string GenusName => "Sitta";

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
