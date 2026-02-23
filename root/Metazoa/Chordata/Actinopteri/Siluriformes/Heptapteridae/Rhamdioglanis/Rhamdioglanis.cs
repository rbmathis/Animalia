using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Rhamdioglanis;

/// <summary>
/// Abstract class for Rhamdioglanis (genus).
/// NCBI TaxId: 2829542
/// </summary>
public abstract class Rhamdioglanis : Heptapteridae, IRhamdioglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamdioglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829542;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamdioglanis";

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
