using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Evermannia;

/// <summary>
/// Abstract class for Evermannia (genus).
/// NCBI TaxId: 1458966
/// </summary>
public abstract class Evermannia : Gobiidae, IEvermannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evermannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1458966;

    /// <inheritdoc />
    public virtual string GenusName => "Evermannia";

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
