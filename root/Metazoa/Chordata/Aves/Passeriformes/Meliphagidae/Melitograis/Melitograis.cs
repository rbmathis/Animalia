using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melitograis;

/// <summary>
/// Abstract class for Melitograis (genus).
/// NCBI TaxId: 1869113
/// </summary>
public abstract class Melitograis : Meliphagidae, IMelitograis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melitograis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1869113;

    /// <inheritdoc />
    public virtual string GenusName => "Melitograis";

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
