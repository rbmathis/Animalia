using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Platydoras;

/// <summary>
/// Abstract class for Platydoras (genus).
/// NCBI TaxId: 238577
/// </summary>
public abstract class Platydoras : Doradidae, IPlatydoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platydoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238577;

    /// <inheritdoc />
    public virtual string GenusName => "Platydoras";

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
