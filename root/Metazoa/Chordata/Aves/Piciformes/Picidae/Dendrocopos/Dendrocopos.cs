using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendrocopos;

/// <summary>
/// Abstract class for Dendrocopos (genus).
/// NCBI TaxId: 51357
/// </summary>
public abstract class Dendrocopos : Picidae, IDendrocopos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocopos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51357;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocopos";

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
