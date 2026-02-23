using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Doras;

/// <summary>
/// Abstract class for Doras (genus).
/// NCBI TaxId: 238594
/// </summary>
public abstract class Doras : Doradidae, IDoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238594;

    /// <inheritdoc />
    public virtual string GenusName => "Doras";

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
