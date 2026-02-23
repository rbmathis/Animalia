using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Melidora;

/// <summary>
/// Abstract class for Melidora (genus).
/// NCBI TaxId: 342391
/// </summary>
public abstract class Melidora : Alcedinidae, IMelidora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melidora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 342391;

    /// <inheritdoc />
    public virtual string GenusName => "Melidora";

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
