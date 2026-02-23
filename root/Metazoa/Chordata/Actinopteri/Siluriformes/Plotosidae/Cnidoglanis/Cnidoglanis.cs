using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Cnidoglanis;

/// <summary>
/// Abstract class for Cnidoglanis (genus).
/// NCBI TaxId: 443775
/// </summary>
public abstract class Cnidoglanis : Plotosidae, ICnidoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnidoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443775;

    /// <inheritdoc />
    public virtual string GenusName => "Cnidoglanis";

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
