using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Neoscopelidae.Neoscopelus;

/// <summary>
/// Abstract class for Neoscopelus (genus).
/// NCBI TaxId: 88700
/// </summary>
public abstract class Neoscopelus : Neoscopelidae, INeoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88700;

    /// <inheritdoc />
    public virtual string GenusName => "Neoscopelus";

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
