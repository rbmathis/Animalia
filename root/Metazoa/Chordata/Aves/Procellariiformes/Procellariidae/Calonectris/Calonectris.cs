using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Calonectris;

/// <summary>
/// Abstract class for Calonectris (genus).
/// NCBI TaxId: 52121
/// </summary>
public abstract class Calonectris : Procellariidae, ICalonectris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calonectris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52121;

    /// <inheritdoc />
    public virtual string GenusName => "Calonectris";

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
