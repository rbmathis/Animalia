using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiophobus;

/// <summary>
/// Abstract class for Myiophobus (genus).
/// NCBI TaxId: 456385
/// </summary>
public abstract class Myiophobus : Tyrannidae, IMyiophobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiophobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456385;

    /// <inheritdoc />
    public virtual string GenusName => "Myiophobus";

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
