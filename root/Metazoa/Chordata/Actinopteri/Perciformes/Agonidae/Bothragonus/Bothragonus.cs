using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Bothragonus;

/// <summary>
/// Abstract class for Bothragonus (genus).
/// NCBI TaxId: 1154616
/// </summary>
public abstract class Bothragonus : Agonidae, IBothragonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothragonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1154616;

    /// <inheritdoc />
    public virtual string GenusName => "Bothragonus";

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
