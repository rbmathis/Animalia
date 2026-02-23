using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Alectroenas;

/// <summary>
/// Abstract class for Alectroenas (genus).
/// NCBI TaxId: 187103
/// </summary>
public abstract class Alectroenas : Columbidae, IAlectroenas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alectroenas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187103;

    /// <inheritdoc />
    public virtual string GenusName => "Alectroenas";

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
