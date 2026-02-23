using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Ceratoscopelus;

/// <summary>
/// Abstract class for Ceratoscopelus (genus).
/// NCBI TaxId: 123250
/// </summary>
public abstract class Ceratoscopelus : Myctophidae, ICeratoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123250;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratoscopelus";

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
