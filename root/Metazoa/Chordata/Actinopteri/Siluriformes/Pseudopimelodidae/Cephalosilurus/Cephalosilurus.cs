using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Cephalosilurus;

/// <summary>
/// Abstract class for Cephalosilurus (genus).
/// NCBI TaxId: 380993
/// </summary>
public abstract class Cephalosilurus : Pseudopimelodidae, ICephalosilurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalosilurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380993;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalosilurus";

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
