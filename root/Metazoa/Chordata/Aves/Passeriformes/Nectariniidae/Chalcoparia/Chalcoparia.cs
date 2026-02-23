using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Chalcoparia;

/// <summary>
/// Abstract class for Chalcoparia (genus).
/// NCBI TaxId: 1118736
/// </summary>
public abstract class Chalcoparia : Nectariniidae, IChalcoparia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalcoparia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118736;

    /// <inheritdoc />
    public virtual string GenusName => "Chalcoparia";

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
