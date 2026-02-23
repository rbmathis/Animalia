using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae.Bihunichthys;

/// <summary>
/// Abstract class for Bihunichthys (genus).
/// NCBI TaxId: 1778384
/// </summary>
public abstract class Bihunichthys : Chaudhuriidae, IBihunichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bihunichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1778384;

    /// <inheritdoc />
    public virtual string GenusName => "Bihunichthys";

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
