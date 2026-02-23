using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Champsocephalus;

/// <summary>
/// Abstract class for Champsocephalus (genus).
/// NCBI TaxId: 52236
/// </summary>
public abstract class Champsocephalus : Channichthyidae, IChampsocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Champsocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52236;

    /// <inheritdoc />
    public virtual string GenusName => "Champsocephalus";

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
