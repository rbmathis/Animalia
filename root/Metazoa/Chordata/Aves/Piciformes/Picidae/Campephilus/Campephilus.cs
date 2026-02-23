using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Campephilus;

/// <summary>
/// Abstract class for Campephilus (genus).
/// NCBI TaxId: 56084
/// </summary>
public abstract class Campephilus : Picidae, ICampephilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campephilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56084;

    /// <inheritdoc />
    public virtual string GenusName => "Campephilus";

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
