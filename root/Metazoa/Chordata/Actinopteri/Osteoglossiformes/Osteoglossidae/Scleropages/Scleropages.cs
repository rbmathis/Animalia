using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Scleropages;

/// <summary>
/// Abstract class for Scleropages (genus).
/// NCBI TaxId: 27726
/// </summary>
public abstract class Scleropages : Osteoglossidae, IScleropages
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scleropages";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27726;

    /// <inheritdoc />
    public virtual string GenusName => "Scleropages";

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
