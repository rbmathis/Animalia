using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phascolarctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phascolarctidae.Phascolarctos;

/// <summary>
/// Abstract class for Phascolarctos (genus).
/// NCBI TaxId: 38625
/// </summary>
public abstract class Phascolarctos : Phascolarctidae, IPhascolarctos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phascolarctos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38625;

    /// <inheritdoc />
    public virtual string GenusName => "Phascolarctos";

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
