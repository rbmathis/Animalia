using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Anostomus;

/// <summary>
/// Abstract class for Anostomus (genus).
/// NCBI TaxId: 303966
/// </summary>
public abstract class Anostomus : Anostomidae, IAnostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303966;

    /// <inheritdoc />
    public virtual string GenusName => "Anostomus";

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
