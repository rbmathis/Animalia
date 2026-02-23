using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Diogenichthys;

/// <summary>
/// Abstract class for Diogenichthys (genus).
/// NCBI TaxId: 123332
/// </summary>
public abstract class Diogenichthys : Myctophidae, IDiogenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diogenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123332;

    /// <inheritdoc />
    public virtual string GenusName => "Diogenichthys";

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
