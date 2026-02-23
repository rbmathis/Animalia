using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Centrodoras;

/// <summary>
/// Abstract class for Centrodoras (genus).
/// NCBI TaxId: 238575
/// </summary>
public abstract class Centrodoras : Doradidae, ICentrodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238575;

    /// <inheritdoc />
    public virtual string GenusName => "Centrodoras";

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
