using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Patagioenas;

/// <summary>
/// Abstract class for Patagioenas (genus).
/// NCBI TaxId: 372310
/// </summary>
public abstract class Patagioenas : Columbidae, IPatagioenas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Patagioenas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372310;

    /// <inheritdoc />
    public virtual string GenusName => "Patagioenas";

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
