using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Platycephalus;

/// <summary>
/// Abstract class for Platycephalus (genus).
/// NCBI TaxId: 270567
/// </summary>
public abstract class Platycephalus : Platycephalidae, IPlatycephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platycephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270567;

    /// <inheritdoc />
    public virtual string GenusName => "Platycephalus";

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
