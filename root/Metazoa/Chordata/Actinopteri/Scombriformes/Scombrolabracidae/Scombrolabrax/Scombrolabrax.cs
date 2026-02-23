using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombrolabracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombrolabracidae.Scombrolabrax;

/// <summary>
/// Abstract class for Scombrolabrax (genus).
/// NCBI TaxId: 372793
/// </summary>
public abstract class Scombrolabrax : Scombrolabracidae, IScombrolabrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scombrolabrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372793;

    /// <inheritdoc />
    public virtual string GenusName => "Scombrolabrax";

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
