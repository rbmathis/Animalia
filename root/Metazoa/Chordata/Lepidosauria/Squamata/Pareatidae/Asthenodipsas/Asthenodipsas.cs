using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Asthenodipsas;

/// <summary>
/// Abstract class for Asthenodipsas (genus).
/// NCBI TaxId: 1334241
/// </summary>
public abstract class Asthenodipsas : Pareatidae, IAsthenodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asthenodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1334241;

    /// <inheritdoc />
    public virtual string GenusName => "Asthenodipsas";

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
