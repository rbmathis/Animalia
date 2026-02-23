using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Indostomidae.Indostomus;

/// <summary>
/// Abstract class for Indostomus (genus).
/// NCBI TaxId: 181449
/// </summary>
public abstract class Indostomus : Indostomidae, IIndostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181449;

    /// <inheritdoc />
    public virtual string GenusName => "Indostomus";

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
