using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cerdale;

/// <summary>
/// Abstract class for Cerdale (genus).
/// NCBI TaxId: 166769
/// </summary>
public abstract class Cerdale : Gobiidae, ICerdale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cerdale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166769;

    /// <inheritdoc />
    public virtual string GenusName => "Cerdale";

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
