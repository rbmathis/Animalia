using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhynchodoras;

/// <summary>
/// Abstract class for Rhynchodoras (genus).
/// NCBI TaxId: 1312665
/// </summary>
public abstract class Rhynchodoras : Doradidae, IRhynchodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312665;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchodoras";

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
