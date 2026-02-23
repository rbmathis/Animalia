using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Micropsitta;

/// <summary>
/// Abstract class for Micropsitta (genus).
/// NCBI TaxId: 57422
/// </summary>
public abstract class Micropsitta : Psittacidae, IMicropsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micropsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57422;

    /// <inheritdoc />
    public virtual string GenusName => "Micropsitta";

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
