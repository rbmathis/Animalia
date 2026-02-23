using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Siphonognathus;

/// <summary>
/// Abstract class for Siphonognathus (genus).
/// NCBI TaxId: 241366
/// </summary>
public abstract class Siphonognathus : Odacidae, ISiphonognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphonognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241366;

    /// <inheritdoc />
    public virtual string GenusName => "Siphonognathus";

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
