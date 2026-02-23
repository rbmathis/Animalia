using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Hylexetastes;

/// <summary>
/// Abstract class for Hylexetastes (genus).
/// NCBI TaxId: 190298
/// </summary>
public abstract class Hylexetastes : Furnariidae, IHylexetastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylexetastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190298;

    /// <inheritdoc />
    public virtual string GenusName => "Hylexetastes";

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
