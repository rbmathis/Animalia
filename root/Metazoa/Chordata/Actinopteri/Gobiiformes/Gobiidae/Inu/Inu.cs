using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Inu;

/// <summary>
/// Abstract class for Inu (genus).
/// NCBI TaxId: 3043668
/// </summary>
public abstract class Inu : Gobiidae, IInu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043668;

    /// <inheritdoc />
    public virtual string GenusName => "Inu";

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
