using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Helopsaltes;

/// <summary>
/// Abstract class for Helopsaltes (genus).
/// NCBI TaxId: 3150801
/// </summary>
public abstract class Helopsaltes : Locustellidae, IHelopsaltes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helopsaltes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150801;

    /// <inheritdoc />
    public virtual string GenusName => "Helopsaltes";

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
