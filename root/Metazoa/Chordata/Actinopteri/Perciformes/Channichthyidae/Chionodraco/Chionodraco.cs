using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chionodraco;

/// <summary>
/// Abstract class for Chionodraco (genus).
/// NCBI TaxId: 34788
/// </summary>
public abstract class Chionodraco : Channichthyidae, IChionodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chionodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34788;

    /// <inheritdoc />
    public virtual string GenusName => "Chionodraco";

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
