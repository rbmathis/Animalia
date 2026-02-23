using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Pterodoras;

/// <summary>
/// Abstract class for Pterodoras (genus).
/// NCBI TaxId: 238588
/// </summary>
public abstract class Pterodoras : Doradidae, IPterodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238588;

    /// <inheritdoc />
    public virtual string GenusName => "Pterodoras";

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
