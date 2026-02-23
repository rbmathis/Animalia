using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Aploactinidae.Cocotropus;

/// <summary>
/// Abstract class for Cocotropus (genus).
/// NCBI TaxId: 990975
/// </summary>
public abstract class Cocotropus : Aploactinidae, ICocotropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cocotropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990975;

    /// <inheritdoc />
    public virtual string GenusName => "Cocotropus";

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
