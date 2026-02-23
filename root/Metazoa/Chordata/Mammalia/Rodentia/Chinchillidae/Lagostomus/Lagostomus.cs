using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Lagostomus;

/// <summary>
/// Abstract class for Lagostomus (genus).
/// NCBI TaxId: 10153
/// </summary>
public abstract class Lagostomus : Chinchillidae, ILagostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10153;

    /// <inheritdoc />
    public virtual string GenusName => "Lagostomus";

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
