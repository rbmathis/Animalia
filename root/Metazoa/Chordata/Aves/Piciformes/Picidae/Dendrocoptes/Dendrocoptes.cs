using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dendrocoptes;

/// <summary>
/// Abstract class for Dendrocoptes (genus).
/// NCBI TaxId: 2821311
/// </summary>
public abstract class Dendrocoptes : Picidae, IDendrocoptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocoptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821311;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocoptes";

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
