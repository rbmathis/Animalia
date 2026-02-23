using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Ceratobranchia;

/// <summary>
/// Abstract class for Ceratobranchia (genus).
/// NCBI TaxId: 930877
/// </summary>
public abstract class Ceratobranchia : Stevardiidae, ICeratobranchia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratobranchia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930877;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratobranchia";

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
