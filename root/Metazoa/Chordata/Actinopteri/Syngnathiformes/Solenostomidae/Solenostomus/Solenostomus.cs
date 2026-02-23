using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Solenostomidae.Solenostomus;

/// <summary>
/// Abstract class for Solenostomus (genus).
/// NCBI TaxId: 270526
/// </summary>
public abstract class Solenostomus : Solenostomidae, ISolenostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solenostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270526;

    /// <inheritdoc />
    public virtual string GenusName => "Solenostomus";

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
