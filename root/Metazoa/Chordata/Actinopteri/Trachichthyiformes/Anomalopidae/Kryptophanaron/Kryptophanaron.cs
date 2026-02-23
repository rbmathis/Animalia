using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Kryptophanaron;

/// <summary>
/// Abstract class for Kryptophanaron (genus).
/// NCBI TaxId: 8280
/// </summary>
public abstract class Kryptophanaron : Anomalopidae, IKryptophanaron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kryptophanaron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8280;

    /// <inheritdoc />
    public virtual string GenusName => "Kryptophanaron";

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
