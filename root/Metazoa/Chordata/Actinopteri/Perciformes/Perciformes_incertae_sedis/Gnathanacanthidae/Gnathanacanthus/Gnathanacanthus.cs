using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Gnathanacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Gnathanacanthidae.Gnathanacanthus;

/// <summary>
/// Abstract class for Gnathanacanthus (genus).
/// NCBI TaxId: 390336
/// </summary>
public abstract class Gnathanacanthus : Gnathanacanthidae, IGnathanacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnathanacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390336;

    /// <inheritdoc />
    public virtual string GenusName => "Gnathanacanthus";

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
