using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Trilepida;

/// <summary>
/// Abstract class for Trilepida (genus).
/// NCBI TaxId: 1334233
/// </summary>
public abstract class Trilepida : Leptotyphlopidae, ITrilepida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trilepida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1334233;

    /// <inheritdoc />
    public virtual string GenusName => "Trilepida";

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
