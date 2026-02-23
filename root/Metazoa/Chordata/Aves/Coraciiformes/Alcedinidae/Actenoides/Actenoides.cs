using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Actenoides;

/// <summary>
/// Abstract class for Actenoides (genus).
/// NCBI TaxId: 342374
/// </summary>
public abstract class Actenoides : Alcedinidae, IActenoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Actenoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342374;

    /// <inheritdoc />
    public virtual string GenusName => "Actenoides";

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
