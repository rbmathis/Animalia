using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Pseudoseisura;

/// <summary>
/// Abstract class for Pseudoseisura (genus).
/// NCBI TaxId: 183168
/// </summary>
public abstract class Pseudoseisura : Furnariidae, IPseudoseisura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoseisura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183168;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoseisura";

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
