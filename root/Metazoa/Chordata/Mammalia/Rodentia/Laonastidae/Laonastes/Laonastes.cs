using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Laonastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Laonastidae.Laonastes;

/// <summary>
/// Abstract class for Laonastes (genus).
/// NCBI TaxId: 340179
/// </summary>
public abstract class Laonastes : Laonastidae, ILaonastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laonastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 340179;

    /// <inheritdoc />
    public virtual string GenusName => "Laonastes";

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
