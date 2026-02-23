using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Astrodoras;

/// <summary>
/// Abstract class for Astrodoras (genus).
/// NCBI TaxId: 1312655
/// </summary>
public abstract class Astrodoras : Doradidae, IAstrodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312655;

    /// <inheritdoc />
    public virtual string GenusName => "Astrodoras";

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
