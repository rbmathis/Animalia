using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Leptocephalus;

/// <summary>
/// Abstract class for Leptocephalus (genus).
/// NCBI TaxId: 556253
/// </summary>
public abstract class Leptocephalus : Nettastomatidae, ILeptocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556253;

    /// <inheritdoc />
    public virtual string GenusName => "Leptocephalus";

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
