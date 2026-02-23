using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae.Nothrotheriops;

/// <summary>
/// Abstract class for Nothrotheriops (genus).
/// NCBI TaxId: 136415
/// </summary>
public abstract class Nothrotheriops : Megatheriidae, INothrotheriops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothrotheriops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136415;

    /// <inheritdoc />
    public virtual string GenusName => "Nothrotheriops";

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
