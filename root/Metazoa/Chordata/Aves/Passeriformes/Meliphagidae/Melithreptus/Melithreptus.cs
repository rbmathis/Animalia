using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Melithreptus;

/// <summary>
/// Abstract class for Melithreptus (genus).
/// NCBI TaxId: 108835
/// </summary>
public abstract class Melithreptus : Meliphagidae, IMelithreptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melithreptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108835;

    /// <inheritdoc />
    public virtual string GenusName => "Melithreptus";

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
