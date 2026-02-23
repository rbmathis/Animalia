using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pseudocolaptes;

/// <summary>
/// Abstract class for Pseudocolaptes (genus).
/// NCBI TaxId: 329507
/// </summary>
public abstract class Pseudocolaptes : Furnariidae, IPseudocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329507;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocolaptes";

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
