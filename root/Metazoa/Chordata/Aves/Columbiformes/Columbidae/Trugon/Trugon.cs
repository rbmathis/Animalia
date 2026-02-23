using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Trugon;

/// <summary>
/// Abstract class for Trugon (genus).
/// NCBI TaxId: 444148
/// </summary>
public abstract class Trugon : Columbidae, ITrugon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trugon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 444148;

    /// <inheritdoc />
    public virtual string GenusName => "Trugon";

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
